$(document).ready(function () { 
    if ($(".js-sub-menu-change-state")
        .click(
            function (e) {
                //expands or contracts the submenu
                e.preventDefault(), $li = $(this).parents("li"),
                $li.hasClass("active") ? ($li.find(".toggle-icon")
                .removeClass("fa-angle-down")
                .addClass("fa-angle-left"),
                $li.removeClass("active")) : ($li.find(".toggle-icon")
                .removeClass("fa-angle-left").addClass("fa-angle-down"),
                $li.addClass("active")), $li.find(".sub-menu").slideToggle(250);
                
            }
        )
    );



})

function currentPage(masterMenu, subMenu) {
      if (masterMenu != null) {
        //Opens submenus corresponding to the page
        $li = $(masterMenu),
                        $li.hasClass("active") ? ($li.find(".toggle-icon")
                        .removeClass("fa-angle-down")
                        .addClass("fa-angle-left"),
                        $li.removeClass("active")) : ($li.find(".toggle-icon")
                        .removeClass("fa-angle-left").addClass("fa-angle-down"),
                        $li.addClass("active")), $li.find(".sub-menu").slideToggle(0);
    }
    //Gives current page a thicker font
    $('span:contains("'+subMenu+'")').css('font-weight', 600);

}
function menuChangeVisibility()
{
    
        if ($(".main-menu").is(':visible')) {
            $(".main-menu").css("display", "none");
        } else {
            $(".main-menu").css("display", "block");
        }
    
}