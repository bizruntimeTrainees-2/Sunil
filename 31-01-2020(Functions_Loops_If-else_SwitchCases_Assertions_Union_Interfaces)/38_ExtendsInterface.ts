interface Iperson{
    name: string;
    gender: string;
}
interface Iemployee extends Iperson{
    empCode: number
} 
let empObj: Iemployee = {
    name: "james",
    empCode: 12345,
    gender: 'Male'
}