<template>
  
</template>

<script>
import axios from "axios";
export default {
  setup() {},
  data: function () {
    return {
      roomDatas: [],
    };
  },
  mounted: function () {
    axios
      .get(
        "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/master/project/fake-room-data.json"
      )
      .then((response) => {
        console.log(response.data);
        this.roomDatas = response.data[0].BedroomDetail;
      });
  },
};
</script>