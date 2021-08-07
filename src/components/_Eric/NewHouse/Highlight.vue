<template>
  <div class="item">
    <button>
      <div class="icon"><img :src="highlight.img" alt="" /></div>
      <div class="info">{{ highlight.chinese }}</div>
    </button>
  </div>
</template>


<style lang="scss" scoped>
.item {
  padding: 0 4px 12px 4px;
  button {
    height: 56px;
    border-radius: 32px;
    display: flex;
    box-sizing: border-box;
    border: 1px solid rgb(176, 176, 176);
    background-color: #fff;
    padding: 0 16px;
    margin: 0;
    align-items: center;
    line-height: 24px;
    font-weight: 600;
  }

  .info {
    white-space: nowrap;
  }

  img {
    height: 24px;
    width: 24px;
  }
  .icon {
    margin-right: 15px;
  }
}
</style>

<script>
export default {
  props: {
    highlight: {
      type: Object,
    },
  },
  mounted() {
    console.log(this.highlight);
  },
};
</script>