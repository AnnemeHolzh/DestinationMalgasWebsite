document.addEventListener('DOMContentLoaded', (event) => {
    // Section 1 Slideshow
    const slides = [
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide1.png",
            backgroundImage: "/Assets/Landing/Img/DM_Offer_Bg.png",
            description: "Get to know us! We aim to provide a comprehensive service to ensure your stay is memorable.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide01.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide2.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Accomidation.png",
            description: "Choose from our variety of houses, cottages, and houseboats.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide02.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide3.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Boating1.png",
            description: "Take advantage of our private jetties and explore the Breede River, offering boat charters and boat rentals.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide03.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide4.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_ServiceProvider.png",
            description: "Supporting our local service providers, contact us for assistance or let us do the marketing for you.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide04.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide5.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Bait.png",
            description: "Stock up on everything you need for a successful fishing trip.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide05.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide6.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Dining.jpeg",
            description: "Visit The Boathouse Pub and Pizza for a delightful meal or choose from a variety of other options.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide06.png"
        },
        {
            svgImage: "/Assets/Landing/TopText/DM_Slide7.png",
            backgroundImage: "/Assets/Landing/Img/DM_TopSection_Hub.png",
            description: "Our hub provides all the information you need about local attractions and activities, office and shop.",
            slideNumber: "/Assets/Landing/TopText/Numbers/slide07.png"
        }
    ];

    let currentSlide = 0;
    const slideImageElement = document.getElementById('slide-svg');
    const slideDescriptionElement = document.getElementById('slide-description');
    const slideNumberElement = document.getElementById('slide-no');
    const sectionElement = document.querySelector('.section1');
    const slideContainer = document.querySelector('.slide-container');
    const carouselTrack = document.querySelector('.carousel-track');
    const carouselImages = document.querySelectorAll('.carousel-image');
    const imageWidth = carouselImages[0].offsetWidth + 10; // Including margin-right
    const visibleWidth = document.querySelector('.carousel-container').offsetWidth;

    // Function to update carousel position
    function updateCarousel() {
        let newTransform = -(currentSlide * imageWidth);

        // Ensure the carousel loops correctly
        if (newTransform < -((carouselImages.length - 2.5) * imageWidth)) {
            newTransform = 0; // Reset to the beginning
        } else if (newTransform > 0) {
            newTransform = -((carouselImages.length - 2.5) * imageWidth); // Reset to the end
        }

        carouselTrack.style.transform = `translateX(${newTransform}px)`;
    }

    function changeSlide(direction) {
        // Apply hidden class to current slide elements for fade-out effect
        slideContainer.classList.add('hidden');

        // Wait for the fade-out animation to complete
        setTimeout(() => {
            if (direction === 'next') {
                currentSlide = (currentSlide + 1) % slides.length;
            } else if (direction === 'prev') {
                currentSlide = (currentSlide - 1 + slides.length) % slides.length;
            }

            // Update background image, SVG image, description, and slide number
            sectionElement.style.backgroundImage = `url(${slides[currentSlide].backgroundImage})`;
            slideImageElement.src = slides[currentSlide].svgImage;
            slideDescriptionElement.textContent = slides[currentSlide].description;
            slideNumberElement.src = slides[currentSlide].slideNumber;

            // Update carousel position
            updateCarousel();

            // Apply visible class to new slide elements for fade-in effect
            slideContainer.classList.remove('hidden');
            slideContainer.classList.add('visible');
        }, 500); // Match this duration to your CSS animation duration
    }

    document.querySelector('.section1 .left-button').addEventListener('click', () => {
        changeSlide('prev');
        updateCarousel();
    });

    document.querySelector('.section1 .right-button').addEventListener('click', () => {
        changeSlide('next');
        updateCarousel();
    });

    // Initialize carousel position
    updateCarousel();

    // Continuously update carousel on window resize
    window.addEventListener('resize', updateCarousel);
});

// Section 3 Slideshow
document.addEventListener('DOMContentLoaded', () => {
    const reasons = [
        {
            h2: "1. Stunning Scenery",
            body: "Explore numerous hiking trails that cater to all levels of fitness. <br><br>From lush riverbanks to rolling hills, every view is a postcard moment.",
            image: "/Assets/Landing/Img/VisitCarousel/reasons1.png"
        },
        {
            h2: "2. Hiking Trails",
            body: "Discover the historical landmarks and learn about the cultural heritage of Malgas. <br><br>Discover the diverse flora and fauna, and perhaps spot some local wildlife.",
            image: "/Assets/Landing/Img/VisitCarousel/reasons2.png"
        },
        {
            h2: "3. Whale Watching",
            body: "Visit during whale season to witness the magnificent spectacle of these gentle giants. <br><br>Infanta and Witsand are renowned for their whale watching opportunities.",
            image: "/Assets/Landing/Img/VisitCarousel/reason3.png"
        },
        {
            h2: "4. Fishing",
            body: "The Breede River is teeming with fish like Cob and Garrick. <br><br>Whether you're a seasoned angler or a beginner, you'll find great spots for fishing.",
            image: "/Assets/Landing/Img/VisitCarousel/reason4.png"
        },
        {
            h2: "5. Bird Watching",
            body: "With a rich variety of bird species, including fish eagles and kingfishers, Malgas is a haven for bird watchers.",
            image: "/Assets/Landing/Img/VisitCarousel/reason5.png"
        },
        {
            h2: "6. Local Attractions",
            body: "Explore historical monuments, visit local pubs and restaurants, and tour nearby wineries.<br><br>There's always something new to discover.",
            image: "/Assets/Landing/Img/VisitCarousel/reason6.png"
        }
    ];

    let currentReason = 0;
    const reasonH2Element = document.getElementById('reason-h2');
    const reasonBodyElement = document.getElementById('reason-body');
    const reasonImageElement = document.getElementById('reason-image');

    function changeReasonSlide(direction) {
        if (direction === 'next') {
            currentReason = (currentReason + 1) % reasons.length;
        } else if (direction === 'prev') {
            currentReason = (currentReason - 1 + reasons.length) % reasons.length;
        }

        reasonH2Element.innerHTML = reasons[currentReason].h2;
        reasonBodyElement.innerHTML = reasons[currentReason].body;
        reasonImageElement.src = reasons[currentReason].image;
    }

    document.querySelector('.section3 .left-button').addEventListener('click', () => changeReasonSlide('prev'));
    document.querySelector('.section3 .right-button').addEventListener('click', () => changeReasonSlide('next'));
});
