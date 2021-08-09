<template>
  <div class="title">
    <div class="icon"></div>
    <h2>
      <div v-if="data.rank">
        {{ data.rank.star }}．{{ data.comments.length }}則評價
      </div>
    </h2>
  </div>
</template>


<style lang="scss" scoped>
.title {
  display: flex;
  align-items: baseline;
  .icon {
    width: 16px;
    height: 16px;
    background-color: red;
    margin-right: 8px;
  }
  h2 {
    font-size: 22px;
    font-weight: 600;
    text-align: start;
    line-height: 32px;
  }
}
</style>

<script>
export default {
  props: ["data"],
};
</script>