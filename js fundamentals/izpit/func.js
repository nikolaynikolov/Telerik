var a = "10 1 2 3 4 5 4 3 2 1 10";

function solve(params) {
    var s = params[0],
        result;
    var str = params;
    var count = 0;
    var temp = 0;
    var splitted = str.split(' ');
    for (var i = 0; i < splitted.length; i++) splitted[i] = +splitted[i];
    for (var i = 1; i < splitted.length - 1; i += 1) {
        if (splitted[i - 1] < splitted[i] && splitted[i] > splitted[i + 1]) {
            count+=1;
            temp = count;
            console.log(count);
            console.log(temp);
            console.log(splitted[2] + splitted[4]);
        }
        for (var i = 0; i < splitted.length; i++) console.log(splitted[i]);
    }
    console.log(temp);
}
