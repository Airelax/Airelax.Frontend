<template>
  <div v-for="(room, index) in roomDatas" :key="room.id">
    <div v-if="index == 0">
      <div class="carousel-item active roomCards">
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </div>
    </div>
    <div v-if="index != 0">
      <div class="carousel-item roomCards">
        <div class="card" style="width: 18rem">
          <img :src="room.picture" class="card-img-top roomPic" alt="..." />
          <div class="card-body">
            臥室{{ index + 1 }}
            <p class="card-text2">{{ room.BedCount }}張{{ room.BedType }}</p>
          </div>
        </div>
      </div>
    </div>
  </div>
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

