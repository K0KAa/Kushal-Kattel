// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const navSlide = () => {
    const burger = document.querySelector('.burger');
    const nav = document.querySelector('.Nav-links');
    const navLinks = document.querySelectorAll('.Nav-links li');

    burger.addEventListener("click", () => {
        nav.classList.toggle('Nav-active');

        //animate links
        navLinks.forEach((link, index) => {
            if (link.style.animation) {
                link.style.animation = ""
            } else {
                link.style.animation = `navLinksFade 0.4s ease forwards ${index / 7 + 0.4}s`;
            }
        });
        //Burger animation
        burger.classList.toggle('toggle');
    });
}

navSlide();