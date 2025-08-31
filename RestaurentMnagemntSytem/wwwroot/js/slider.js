class SmoothSlider {
    constructor() {
        this.currentSlide = 0;
        this.slides = document.querySelectorAll('.mySlides');
        this.dots = document.querySelectorAll('.dot');
        this.totalSlides = this.slides.length;
        this.autoSlideInterval = null;
        this.isTransitioning = false;

        this.init();
    }

    init() {
        // Ensure first slide is active
        this.showSlide(0);
        this.startAutoSlide();

        // Pause auto-slide on hover
        const container = document.querySelector('.slideshow-container');
        if (container) {
            container.addEventListener('mouseenter', () => this.stopAutoSlide());
            container.addEventListener('mouseleave', () => this.startAutoSlide());
        }
    }

    showSlide(index) {
        // Prevent rapid clicking issues
        if (this.isTransitioning) return;

        this.isTransitioning = true;

        // Remove active class from current slide and dot
        if (this.slides[this.currentSlide]) {
            this.slides[this.currentSlide].classList.remove('active');
        }
        if (this.dots[this.currentSlide]) {
            this.dots[this.currentSlide].classList.remove('active');
        }

        // Update current slide index
        this.currentSlide = index;

        // Add active class to new slide and dot
        if (this.slides[this.currentSlide]) {
            this.slides[this.currentSlide].classList.add('active');
        }
        if (this.dots[this.currentSlide]) {
            this.dots[this.currentSlide].classList.add('active');
        }

        // Reset transition flag after animation completes
        setTimeout(() => {
            this.isTransitioning = false;
        }, 500);
    }

    nextSlide() {
        const nextIndex = (this.currentSlide + 1) % this.totalSlides;
        this.showSlide(nextIndex);
    }

    prevSlide() {
        const prevIndex = (this.currentSlide - 1 + this.totalSlides) % this.totalSlides;
        this.showSlide(prevIndex);
    }

    goToSlide(slideNumber) {
        const index = slideNumber - 1;
        if (index !== this.currentSlide && index >= 0 && index < this.totalSlides) {
            this.showSlide(index);
        }
    }

    startAutoSlide() {
        this.stopAutoSlide(); // Clear any existing interval
        this.autoSlideInterval = setInterval(() => {
            this.nextSlide();
        }, 5000); // Change slide every 5 seconds
    }

    stopAutoSlide() {
        if (this.autoSlideInterval) {
            clearInterval(this.autoSlideInterval);
            this.autoSlideInterval = null;
        }
    }
}

// Initialize slider when DOM is loaded
document.addEventListener('DOMContentLoaded', function () {
    // Check if slider elements exist
    if (document.querySelector('.slideshow-container')) {
        const slider = new SmoothSlider();

        // Global functions for onclick handlers
        window.changeSlide = function (direction) {
            if (direction === 1) {
                slider.nextSlide();
            } else {
                slider.prevSlide();
            }
        };

        window.goToSlide = function (slideNumber) {
            slider.goToSlide(slideNumber);
        };
    }
});