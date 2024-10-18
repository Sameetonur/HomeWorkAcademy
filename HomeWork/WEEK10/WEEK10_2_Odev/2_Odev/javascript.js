$(document).ready(function () {
    function loadPosts() {
        $.ajax({
            url: 'https://fakestoreapi.com/products',
            method: 'GET',
            success: function (posts) {
                let postsHtml = '';
                posts.forEach(post => {
                    postsHtml += `
                    <div class="col-2">
                    <img src="${post.image}" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">${post.title}</h5>
                        <p class="card-text">Fiyat:${post.price}</p>
                        <p class="card-text">${post.description}</p>
                        <a href="#" class="btn btn-primary">Sepete Ekle</a>
                    </div>
                    </div>
                    `;
                });
                $('#posts').html(postsHtml);
            },
            error: function (err) {
                console.log(err);
            }
        });
    };

    loadPosts();
});

