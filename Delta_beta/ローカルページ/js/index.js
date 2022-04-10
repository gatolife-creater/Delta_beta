$(window).on('load', function() {
    let container = document.getElementById('search-wrapper');
    container.classList.add('active');
    container.click();
});



const search = () => {
    let word = document.getElementById("search-input").value;
    if (word.includes("://") ||
        word.includes(".co") ||
        word.includes(".jp") ||
        word.includes(".org") ||
        word.includes(".com")) {
        location.href = `http://${word}`;
    } else {
        location.href = `https://www.google.com/search?q=${word}`;
    }
}

function searchToggle(obj, evt) {
    let container = $(obj).closest('#search-wrapper');
    if (!container.hasClass('active')) {
        container.addClass('active');
        evt.preventDefault();
    } else if (container.hasClass('active') && $(obj).closest('.input-holder').length == 0) {
        container.removeClass('active');
        // clear input
        container.find('.search-input').val('');
    }
}