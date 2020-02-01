var fruit: Array<string> = ['Apple', 'Orange', 'Banana']; 
fruit.sort(); 
console.log(fruit); //output: [ 'Apple', 'Banana', 'Orange' ]

console.log(fruit.pop()); //output: Orange

fruit.push('Papaya'); 
console.log(fruit); //output: ['Apple', 'Banana', 'Papaya']

fruit = fruit.concat(['Fig', 'Mango']); 
console.log(fruit); //output: ['Apple', 'Banana', 'Papaya', 'Fig', 'Mango'] 

console.log(fruit.indexOf('Papaya'));//output: 2