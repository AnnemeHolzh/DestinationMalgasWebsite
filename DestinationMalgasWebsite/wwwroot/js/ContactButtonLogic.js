document.addEventListener('DOMContentLoaded', function () {
    const sendButton = document.querySelector('.sendButtonImage');

    // Update image paths
    const defaultSrc = '/Assets/Contact/SendButton/sendDefault.svg';
    const hoverSrc = '/Assets/Contact/SendButton/sendHover.svg';
    const clickSrc = '/Assets/Contact/SendButton/sendClick.svg';

    sendButton.src = defaultSrc; // Set default image

    sendButton.addEventListener('mouseover', function () {
        sendButton.src = hoverSrc;
    });

    sendButton.addEventListener('mouseout', function () {
        sendButton.src = defaultSrc;
    });

    sendButton.addEventListener('mousedown', function () {
        sendButton.src = clickSrc;
    });

    sendButton.addEventListener('mouseup', function () {
        sendButton.src = hoverSrc; // Or default, depending on your preference
    });
});
