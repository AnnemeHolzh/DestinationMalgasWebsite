document.addEventListener('DOMContentLoaded', (event) => {
    const slides = [
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_1.png",
            backgroundImage: "/Assets/Landing/Img/DM_Offer_Bg.png",
            description: "Get to know us ! We aim to provide a comprehensive service to ensure your stay is memorable"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_2.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Accomidation.png",
            description: "Choose from our variety of houses, cottages, and houseboats."
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_3.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Boating1.png",
            description: "Take advantage of our private jetties and explore the Breede River, offering boat charters and boat rentals."
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_4.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_ServiceProvider.png",
            description: "Supporting our local service providers, contact us for assistance or let us do the marketing for you."
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_5.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Bait.png",
            description: "Stock up on everything you need for a successful fishing trip."
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_6.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Dining.jpeg",
            description: "Visit The Boathouse Pub and Pizza for a delightful meal or choose from a variety of other options."
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_TopText_7.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Hub.png",
            description: "Our hub provides all the information you need about local attractions and activities, office and shop."
        }
    ];

    let currentSlide = 0;
    const slideImageElement = document.getElementById('slide-svg');
    const slideDescriptionElement = document.getElementById('slide-description');
    const sectionElement = document.querySelector('.section1');

    // Function to change slide
    function changeSlide(direction) {
        if (direction === 'next') {
            currentSlide = (currentSlide + 1) % slides.length;
        } else if (direction === 'prev') {
            currentSlide = (currentSlide - 1 + slides.length) % slides.length;
        }

        // Update background image, SVG image, and description
        sectionElement.style.backgroundImage = `url('${slides[currentSlide].backgroundImage}')`;
        slideImageElement.src = slides[currentSlide].svgImage;
        slideDescriptionElement.textContent = slides[currentSlide].description;
    }

    document.querySelector('.left-button').addEventListener('click', () => changeSlide('prev'));
    document.querySelector('.right-button').addEventListener('click', () => changeSlide('next'));
});
