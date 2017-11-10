var moveSpeed = 100;

function Start () {

}

function Update () {
//left
 if (Input.GetKey ("a")){
 
     rigidbody.AddForce(Vector3.right * -moveSpeed * Time.deltaTime);
     }
 //Right
 if(Input.GetKey("d")){
 
     rigidbody.AddForce(Vector3.right * moveSpeed * Time.deltaTime);
     }

 //Up
 if (Input.GetKey ("w")){
 
     rigidbody.AddForce(Vector3.up* moveSpeed * Time.deltaTime);
     
     }
 //Down
 if(Input.GetKey ("s")){
 
     rigidbody.AddForce(Vector3.down * moveSpeed * Time.deltaTime);
     }

     

}