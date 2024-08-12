function Comp(){
    return user.firstName + " " + user.lastName;

}

const user = {
    firstName: "Hazem",
    lastName: "Yassien"
}

const element = (
    <h1>
        Hello, {Comp(user)}!
    </h1>
)
export default Comp;