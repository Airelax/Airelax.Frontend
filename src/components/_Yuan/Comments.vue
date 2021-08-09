<template>
  <div
    class="my-row"
    v-for="(item,key,index) in rank"
    :key="index"
    v-show="key!=='star'"
  >
    <div class="char">
      <span>{{setting.find(x=>x.eng===key).ch}}</span>
      <div class="charVaule">
        <div class="char-box"></div>
        <div :style="{width: percent(item)}" class="char-mask"></div>
        <span>{{Number.parseFloat(item).toFixed(1)}}</span>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .my-row * {
    color: #222;
  }
  .my-row {
    width: 50%;
  }
  .char {
    height: 36px;
    line-height: 36px;
    padding: 0 8px;
    margin-right: 7.6375vw;
    display: flex;
    justify-content: space-between;
  }
  .charVaule {
    display: flex;
    position: relative;
  }
  .charVaule .char-box,
  .charVaule .char-mask {
    height: 4px;
    border-radius: 2px;
    margin: auto;
  }
  .charVaule .char-box {
    width: 11.312vw;
    background-color: rgb(221, 221, 221);
  }
  .charVaule .char-mask {
    width: 5.656vw;
    background-color: #222;
    position: absolute;
    top: 16px;
  }
  .charVaule span {
    font-size: 12px;
    margin-left: 10px;
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
        return (item / 5) * 11.312 + "vw";
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