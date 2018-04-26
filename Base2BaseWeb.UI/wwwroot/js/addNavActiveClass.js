$('.tabpanel li').on('click', addNavActiveClass);
$('.navVertical li').on('click', addNavActiveClass);

$('.navVerticalClients li').on('click', addNavActiveClass);

function addNavActiveClass() {
    $(this).siblings().removeClass('active');
    $(this).addClass('active');
}