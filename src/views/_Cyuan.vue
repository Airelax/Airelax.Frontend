<template>
  <div class="container-md-fluid" v-if="get">
    <ResultRoom :rooms="rooms" :nightCount="nightCount"></ResultRoom>
    <BrowsingRecord :rooms="rooms" :nightCount="nightCount"></BrowsingRecord>
  </div>
</template>
<script>
import axios from "axios";
import ResultRoom from "../components/_Cyuan/_cyuan.vue";
import BrowsingRecord from "../components/_Cyuan/BrowsingRecord.vue";
export default {
  components: {
    ResultRoom,
    BrowsingRecord,
  },
  data() {
    return {
      rooms: Array,
      nightCount: 3,
      get: false,
    };
  },
  created() {
    axios
      .get(
        "https://raw.githubusercontent.com/Airelax/Airelax.Frontend/SHOP-48/fake-search-data.json"
      )
      .then((res) => {
        this.rooms = res.data;
        this.get = true;
      });
  },
};
</script>