<template>
  <div
    class="my-row"
    v-for="(item, key, index) in rank"
    :key="index"
    v-show="key !== 'star'"
  >
    <div class="char">
      <span>{{ setting.find((x) => x.eng === key).ch }}</span>
      <div class="charVaule">
        <div class="char-box"></div>
        <div :style="{ width: percent(item) }" class="char-mask"></div>
        <span>{{ Number.parseFloat(item).toFixed(1) }}</span>
      </div>
    </div>
  </div>
</template>

<style scoped>
.my-row {
  width: 100%;
  padding: 0 8px;
}
.char {
  height: 32px;
  line-height: 32px;
  color: #222;
  display: flex;
  justify-content: space-between;
  font-size: 14px;
}
.charVaule {
  display: flex;
  position: relative;
}
.charVaule .char-box,
.charVaule .char-mask {
  height: 4px;
  border-radius: 2px;
}
.charVaule .char-box {
  width: 35.78vw;
  background-color: rgb(221, 221, 221);
  margin: auto;
}
.charVaule .char-mask {
  width: 17.89vw;
  background-color: #222;
  position: absolute;
  top: 14px;
}
.charVaule span {
  font-size: 12px;
  margin-left: 10px;
}
@media screen and (min-width: 768px) {
  .my-row {
    width: 50%;
  }
  .charVaule .char-box {
    width: 13.25vw;
  }
  .charVaule .char-mask {
    width: 6.625vw;
  }
}
@media screen and (min-width: 1200px) {
  .my-row {
    width: 100%;
  }
  .charVaule .char-box {
    width: 8.127vw;
  }
  .charVaule .char-mask {
    width: 4.0635vw;
  }
}
</style>

<script>
import setting from "./satting";
import axios from "axios";

export default {
  props: ["rank"],
  data() {
    return {
      setting: setting.chineseTranslation,
    };
  },
  methods: {
    percent(item) {
      return (item / 5) * 35.78 + "vw";
    },
  },
  created: function () {
    const api = "https://bs-howard.github.io/Homework/fake-room-data.json";
    axios
      .get(api)
      .then((response) => {
        this.data = response.data;
      })
      .catch((error) => {
        console.log(error);
      });
  },
};
</script>