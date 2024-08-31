document.addEventListener('DOMContentLoaded', () => {
    console.log('Script loaded'); // Debugging line

    const images = [
        '/Assets/Destination/malagasColumn.jpg',
        '/Assets/Destination/ferryColumn.jpg',
        '/Assets/Destination/boathouseColumn.jpg',
        '/Assets/Destination/bushColumn.jpg',
        '/Assets/Destination/sijnnColumn.jpg',
        '/Assets/Destination/gruntersColumn.jpg',
        '/Assets/Destination/dehoopColumn.jpg',
        '/Assets/Destination/tradingColumn.jpg',
        '/Assets/Destination/figColumn.jpg',
        '/Assets/Destination/bitesColumn.jpg'
    ];

    const urls = [
        '/Destination/Malgas',
        '/Destination/MalgasFerry',
        '/Destination/BoathousePizzaAndPub',
        '/Destination/BushPub',
        '/Destination/SijnnWineEstate',
        '/Destination/Grunters',
        '/Destination/DeHoop',
        '/Destination/TheTradingPost',
        '/Destination/TheFigTree',
        '/Destination/Bites'
    ];

    let startIndex = 0;

    function updateGridImages() {
        const gridItems = document.querySelectorAll('.grid-item');
        gridItems.forEach((gridItem, index) => {
            const imagePath = images[(startIndex + index) % images.length];
            const url = urls[(startIndex + index) % urls.length];

            // Clear existing content
            gridItem.innerHTML = '';

            // Create anchor tag
            const anchor = document.createElement('a');
            anchor.href = url;

            // Create image tag
            const img = document.createElement('img');
            img.src = imagePath;
            img.alt = 'Destination Image';

            // Append image to anchor, and anchor to grid item
            anchor.appendChild(img);
            gridItem.appendChild(anchor);
        });
    }

    function handleArrowClick(direction) {
        if (direction === 'right') {
            startIndex = (startIndex + 1) % images.length;
        } else if (direction === 'left') {
            startIndex = (startIndex - 1 + images.length) % images.length;
        }
        updateGridImages();
    }

    // Attach event listeners to the arrows by ID
    document.getElementById('left-arrow').addEventListener('click', () => {
        handleArrowClick('left');
    });

    document.getElementById('right-arrow').addEventListener('click', () => {
        handleArrowClick('right');
    });

    updateGridImages(); // Initial image load
});
