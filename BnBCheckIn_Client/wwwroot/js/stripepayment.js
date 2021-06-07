redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51IzewzLqwdwQTvGTweOaBFYE2RSP0XM7OHzV3kxs4JsJ4L1KIVNRJR34TDtPNDJ5N7G58UjRPu2Wo7ninAPUkRwx00EufOdiPA');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
};