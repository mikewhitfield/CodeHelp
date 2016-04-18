$(document).ready(function () {

    /* ==========================================================================
       Add to Cart
       ========================================================================= */
    var sum = 0;
    var kidSum = 0;
    var total = 0;

    $('.total').text(total);
    $('.click-num').text(sum);
    $('.adults .row-total').text(sum);
    $('.kids .row-total').text(sum);

    $('#adults .plus a').click(function (e) {
        e.preventDefault();

        if (sum < 5) {
            sum++;

            $('#adults .click-num').text(sum);
            $('.adults .row-total').text(sum);
        }

        if (total <= 60) {
            $('.total').text(parseInt(total + 20));
            total += 20;
        }

        $('.newTotal').val(total);
    });

    $('#adults .minus a').click(function (e) {
        e.preventDefault();

        if (sum > 0) {
            sum--;

            $('#adults .click-num').text(sum);
            $('.adults .row-total').text(sum);
        }

        if (total >= 20) {
            $('.total').text(parseInt(total - 20));
            total -= 20;
        }

        $('.newTotal').val(total);
    });


    $('#kids .plus a').click(function (e) {
        e.preventDefault();

        if (kidSum < 5) {
            kidSum++;

            $('#kids .click-num').text(kidSum);
            $('.kids .row-total').text(kidSum);
        }

        if (total <= 70) {
            $('.total').text(parseInt(total + 10));
            total += 10;
        }

        $('.newTotal').val(total);
    });

    $('#kids .minus a').click(function (e) {
        e.preventDefault();

        if (kidSum > 0) {
            kidSum--;

            $('#kids .click-num').text(kidSum);
            $('.kids .row-total').text(kidSum);
        }

        if (total >= 10) {
            $('.total').text(parseInt(total - 10));
            total -= 10;
        }

        $('.newTotal').val(total);
    });


    /* ==========================================================================
       Banner Img Change
       ========================================================================= */
    
    //$('.main-img').load(function () {

    //});

    var bannerBg = $('.main-img ').attr('src');
    $('.banner.detail').css('background-image', 'url(' + bannerBg + ')');

    /* ==========================================================================
       Navigation
       ========================================================================= */
    $('.header-wrapper header nav  li  + a ').wrapAll('<li/>');

    /* ==========================================================================
       Send Total
       ========================================================================= */
    var tots = $('.total').text()
    $('.newTotal').val(tots);

    /* ==========================================================================
       Limit Text
       ========================================================================= */
    $('.detail-info p').each(function () {
        var text = $(this).text().substr(0, 100) + '...'
        $(this).text(text);
    });

    $('.big-price strong').each(function () {
        var price = $(this).text()
        var newPrice =  price.substr(0, price.length - 3)
        $(this).text('$' + newPrice);
    });


    /* ==========================================================================
       Filters
       ========================================================================= */
    $('.top-side-menu li').each(function () {
        $(this).click(function () {
            var catId = $(this).attr('data-category');

            $(this).addClass('highlight').siblings().removeClass('highlight');

            $('.map_tour_info').each(function () {
                var tourName = $(this).find('.tour-name').text();
                if (tourName != catId) {
                    $(this).addClass('hidden');
                } else {
                    $(this).removeClass('hidden');
                }
            });
        });
    });

    $('.nav-all').click(function () {
        $('.map_tour_info').each(function () {
            $(this).removeClass('hidden');
        });
    });


    $('#priceRanger').change(function () {
        var prValue = $('#priceRanger').val();

        if (prValue != '') {
            var min = parseFloat(prValue.split('-')[0]);
            var max = parseFloat(prValue.split('-')[1]);
            var price;

            $('.map_tour_info').each(function () {
                price = $(this).find('.big-price strong').text();
                myPrice = parseFloat(price.substring(1, price.length));

                if (myPrice >= min && myPrice <= max) {
                    $(this).removeClass('hidden');
                } else {
                    $(this).addClass('hidden');
                }
            });
        } else {
            $('.map_tour_info').each(function () {
                $(this).removeClass('hidden');
            });
        }
    });
});


