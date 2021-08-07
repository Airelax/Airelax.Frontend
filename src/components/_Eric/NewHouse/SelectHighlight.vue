<template>
  <div class="contain">
    <div class="item-group">
      <Hightlight
        v-for="highlight in highlights"
        :key="highlight.mapping"
        :highlight="highlight"
      ></Hightlight>
    </div>
  </div>
</template>


<style lang="scss" scoped>
.contain {
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100%;
  box-sizing: border-box;

  .item-group {
    display: flex;
    flex-wrap: wrap;
    width: 70%;
  }
}
</style>

<script>
import setting from "./setting.js";
import Hightlight from "./Highlight.vue";
export default {
  data() {
    return {
      highlights: setting.houseHighlight,
    };
  },
  components: {
    Hightlight,
  },
};
</script>