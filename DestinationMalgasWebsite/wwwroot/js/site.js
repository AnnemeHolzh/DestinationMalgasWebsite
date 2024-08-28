function adjustScale() {
    var container = document.getElementById('scaled-container');
    var windowWidth = window.innerWidth;
    var windowHeight = window.innerHeight;

    var scaleX = windowWidth / 1920;
    var scaleY = windowHeight / 1080;

    var scale = Math.min(scaleX, scaleY);

    container.style.transform = 'scale(' + scale + ')';

    // Set CSS variables for scaling other elements
    document.documentElement.style.setProperty('--scale-factor', scale);
}

// Adjust the scale when the page loads
window.onload = adjustScale;

// Adjust the scale when the window is resized
window.onresize = adjustScale;
