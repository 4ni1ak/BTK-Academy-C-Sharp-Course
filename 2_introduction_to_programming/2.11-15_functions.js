var number1 = Math.random()//Math.random() Generates numbers between 0 and 1
var number2 = 16
var number3 = 3
var number4 = 49
var number5 = 49
var number6 = 49
console.log('Colone : ' + number1 + ' ' + number2 + ' ' + number3 + ' ' + number4 + ' ' + number5 + ' ' + number6)
number1 = Math.ceil(Math.random())//Math.random() Generates numbers between 0 and 1 Math.ceil round up the number
number2 = Math.ceil(Math.random() * 49)
number3 = Math.ceil(Math.random() * 49)
number4 = Math.ceil(Math.random() * 49)
number5 = Math.ceil(Math.random() * 49)
number6 = Math.ceil(Math.random() * 49)
console.log('Colone : ' + number1 + ' ' + number2 + ' ' + number3 + ' ' + number4 + ' ' + number5 + ' ' + number6)

function generatesNumber() {
    console.log(Math.ceil(Math.random() * 49))
}
generatesNumber()

function generatesNumbers() {
    return Math.ceil(Math.random() * 60)
}

number1 = generatesNumbers()
number2 = generatesNumbers()
number3 = generatesNumbers()
number4 = generatesNumbers()
number5 = generatesNumbers()
number6 = generatesNumbers()
console.log('Colone : ' + number1 + ' ' + number2 + ' ' + number3 + ' ' + number4 + ' ' + number5 + ' ' + number6)

function generatesNumberWithParameter(topLmt) {//If we wrote "topLmt=50", if no value is set in the parameter section, 50 would be sent to the function by default
    return Math.ceil(Math.random() * topLmt)
}
number1 = generatesNumbers(60)
number2 = generatesNumbers(40)
number3 = generatesNumbers(80)
number4 = generatesNumbers(30)
number5 = generatesNumbers(20)
number6 = generatesNumbers(90)
console.log('Colone : ' + number1 + ' ' + number2 + ' ' + number3 + ' ' + number4 + ' ' + number5 + ' ' + number6)