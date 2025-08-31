document.addEventListener("DOMContentLoaded", function () {
    const links = document.querySelectorAll(".sidebar-link");
    const currentPath = window.location.pathname.toLowerCase();

    links.forEach(link => {
        const href = link.getAttribute("href")?.toLowerCase();

        if (href && currentPath.startsWith(href)) {
            // Add active styles
            link.classList.add("bg-[#ed8936]", "text-white");
        } else {
            // Remove active styles if not current page
            link.classList.remove("bg-[#ed8936]", "text-white");
        }
    });
});
