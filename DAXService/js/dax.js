$(function () {
    // Hide Language B when the web page loads
    $('.languageEN').hide();
    $('.languageDE').click(function () {
        // find all content with .languageA under the div post-content and hide it
        $(this).parent().find('.languageDE').fadeToggle('slow', function () {
            // find all content with .languageB under the div post-content and show it
            $(this).parent().find('.languageEN').show();
        });
    });
    $('.languageEN').click(function () {
        // find all content with .languageB under the div post-content and hide it
        $(this).parent().find('.languageEN').fadeToggle('slow', function () {
            // find all content with .languageA under the div post-content and show it
            $(this).parent().find('.languageDE').show();
        });
    });
});