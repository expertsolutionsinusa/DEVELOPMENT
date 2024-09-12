using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using NonFactors.Mvc.Grid;

namespace MVC_Grid.Extentions
{
    public static class GridExtensions
    {
        public static IHtmlContent GridWithResizableColumns<T>(this IHtmlHelper helper, IEnumerable<T> model, Action<IGridColumnsOf<T>> buildColumns)
         where T : class  // Adding the reference type constraint
        {
            var grid = helper.Grid(model)
                             .Build(buildColumns)
                             .Using(GridFilterMode.Row)
                             .Empty("No data found")
                             .Filterable()
                             .Sortable();

            // Add the resizable script to the grid
            var script = @"
            <script>
                $(function () {
                    const applyResizable = function () {
                        $('.mvc-grid').each(function () {
                            const table = $(this);

                            // Append resizer div to each header
                            table.find('th').each(function () {
                                if ($(this).find('.resizer').length === 0) {
                                    $(this).append('<div class=""resizer""></div>');
                                }
                            });

                            // Handle the resizing
                            let startX, startWidth, index;
                            table.on('mousedown', '.resizer', function (e) {
                                startX = e.pageX;
                                const th = $(this).parent();
                                startWidth = th.width();
                                index = th.index();

                                $(document).on('mousemove.resize', function (e) {
                                    const width = startWidth + (e.pageX - startX);
                                    th.css('width', width + 'px');
                                    table.find('td:nth-child(' + (index + 1) + ')').css('width', width + 'px');
                                });

                                $(document).on('mouseup', function () {
                                    $(document).off('mousemove.resize');
                                });
                            });
                        });
                    };

                    // Apply resizable feature on document ready
                    applyResizable();
                });
            </script>";

            // Return the grid with the resizable functionality
            return new HtmlString(grid.ToString() + script);
        }
    }

}
