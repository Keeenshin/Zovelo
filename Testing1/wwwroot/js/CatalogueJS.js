document.addEventListener("DOMContentLoaded", function () {
    renderCatalogue();
});

function renderCatalogue() {
    const productContainer = document.querySelector('.product-list');
    productContainer.innerHTML = "";

    if (!products || products.length === 0) {
        console.error("No products available");
        return;
    }

    const sortedProducts = products.sort((a, b) => new Date(b.dateAdded) - new Date(a.dateAdded));

    sortedProducts.forEach(product => {
        const productCard = `
            <div class="product-card" data-type="${product.type}" data-price="${parseFloat(product.price)}" data-bestselling="${product.bestSelling}">
                <img src="/images/${product.imageUrls.split(',')[0]}" alt="${product.name}"> 
                <h2>${product.name}</h2>
                <p>${product.description}</p>
                <p class="price">$${product.price.toFixed(2)}</p>
                <a href="/Home/ProductDetails?id=${product.id}" class="buy-button">View Details</a>
            </div>
        `;
        productContainer.insertAdjacentHTML('beforeend', productCard);
    });
}

function filterProducts() {
    const type = document.getElementById("filter-type").value;
    const price = document.getElementById("filter-price").value;
    const bestSelling = document.getElementById("filter-best-selling").value;

    const products = document.getElementsByClassName("product-card");

    for (let i = 0; i < products.length; i++) {
        const productType = products[i].getAttribute("data-type");
        const productPrice = parseFloat(products[i].getAttribute("data-price"));
        const productBestSelling = products[i].getAttribute("data-bestselling");

        let showProduct = true;

        // Apply filters based on type, price, and best-selling status
        if (type && type !== productType) {
            showProduct = false;
        }

        if (price === "low-to-high") {
            products[i].style.order = productPrice;
        } else if (price === "high-to-low") {
            products[i].style.order = -productPrice;
        }

        if (bestSelling === "best-selling" && productBestSelling !== "true") {
            showProduct = false;
        }

        products[i].style.display = showProduct ? "block" : "none";
    }
}

function resetFilters() {
    document.getElementById("filter-type").value = "";
    document.getElementById("filter-price").value = "";
    document.getElementById("filter-best-selling").value = "";

    filterProducts();
}
