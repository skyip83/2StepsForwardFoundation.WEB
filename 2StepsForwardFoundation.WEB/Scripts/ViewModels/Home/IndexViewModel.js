var IndexViewModel = (function () {
    var init = function () {
        $('.carousel-photos').slick({
            adaptiveHeight: true,
            autoplay: true,
            autoplaySpeed: 2000,
            dots: true,
            centerMode: true,
            infinite: true,
            lazyLoad: 'ondemand',
            slidesToShow: 4,
            slidesToScroll: 4,
            variableWidth: true,
            responsive: [
              {
                  breakpoint: 1024,
                  settings: {
                      slidesToShow: 3,
                      slidesToScroll: 3,
                      infinite: true,
                      dots: true
                  }
              },
              {
                  breakpoint: 600,
                  settings: {
                      slidesToShow: 2,
                      slidesToScroll: 2
                  }
              },
              {
                  breakpoint: 480,
                  settings: {
                      slidesToShow: 1,
                      slidesToScroll: 1
                  }
              }
            ]
        });
    }

    return {
        init: init
    }
})();