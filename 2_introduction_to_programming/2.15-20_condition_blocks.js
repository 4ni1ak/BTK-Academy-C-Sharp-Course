var mark = 60
if (mark > 50) {
    console.log('You Passed')
} else if (mark >= 40) {
    console.log('Makeup exam')
}
else {
    console.log('You Stayed')
}
// if(mark<=50){
//      console.log('You Stayed')
// }

////////////////////////////////////

//find the largest number
var number1 = 29
var number1 = 30
var number2 = 2
var largest = number1
if (largest < number2) {
    largest = number2

}
if (largest < number3) {
    largest = number3

}
console.log(largest)
////////////////////////////////////
number1 = 10
number2 = 10
number3 = 30
if (number1 == number2 || number1 == number3) {
    console.log('Equal')
}
///////////////////////////////////////
number1 = 1
while (number1 <= 10) {
    console.log(number1)
    number1++
}
////////////////////////////////////////
for (var i = 0; i < 100; i++) {
    console.log(i)
}
///////////////////////////////////////////
function generatesNumberWithParameter(topLmt = 50) {
    return Math.ceil(Math.random() * topLmt)
}
for (var j = 0; j <= 8; j++) {
    console.log(j + ". Colone")
    for (i = 0; i < 6; i++) {
        console.log(generatesNumberWithParameter())
    }
}