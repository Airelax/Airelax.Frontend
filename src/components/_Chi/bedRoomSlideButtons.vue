<template>
  <button
    class="carousel-control-prev"
    type="button"
    data-bs-target="#carouselExampleControls"
    data-bs-slide="prev"
  >
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button
    class="carousel-control-next"
    type="button"
    data-bs-target="#carouselExampleControls"
    data-bs-slide="next"
  >
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</template>

<script>
import axios from "axios"
export default {
  setup() {
    
  },
  data:function(){
        return{
            roomDatas:[],
            
        }
    },
  mounted:function(){
        axios
            .get(
                "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/master/project/fake-room-data.json"
            )
            .then((response)=>{
                console.log(response.data)
                this.roomDatas=response.data[0].BedroomDetail
                
            })
    },
}
</script>