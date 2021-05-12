window.addEventListener("resize", function () {
    ChangeClass();
});
ChangeClass();
function ChangeClass() {
    if (window.matchMedia("(min-width: 575px)").matches) {
        document.querySelectorAll(".nav-item a img").forEach((item) => {
            item.classList.add("d-block");
        });;
    } else {
        document.querySelectorAll(".nav-item a img").forEach((item) => {
            item.classList.remove("d-block");
        });
    }
}
