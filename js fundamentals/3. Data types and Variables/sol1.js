function solve(params) {
    var s = params[0],
        result;


    var str = params;
    splitted = str.split(' ');
    var counter = 0;
    array = new Array();
    for (i = 1; i < splitted.length - 1; i+=1) {
        if (splitted [i - 1] < splitted [i] && splitted [i + 1] < splitted [i]) {
            counter++;
        }
    }



}

console.log(counter)
console.log(result)
}
