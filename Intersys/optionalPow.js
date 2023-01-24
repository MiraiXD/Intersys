function optionalPow(a, b) {
    let confirmUser = confirm('Press OK to raise a to the power of b. Press Cancel otherwise');
    if (confirmUser)
        return Math.pow(a, b);
    else
        return Math.pow(b, a);
}