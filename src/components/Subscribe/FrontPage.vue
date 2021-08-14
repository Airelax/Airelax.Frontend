<template>
  <div class="row frontPage">
    <div class="col-1 btn">
      <img src="@/assets/image/Subscribe/toFrontPage.svg" alt="toFrontPage" />
    </div>
    <div class="col-11">
      <h2>申請預訂</h2>
    </div>
  </div>
</template>
<style lang="scss" scoped>
.frontPage {
  box-sizing: border-box;
  padding: 25px 30px;
  background-color: #fff;
  position: sticky;
  top: 0;
  .col-1.btn {
    display: flex;
    padding: 0;
    img {
      margin-right: auto;
      width: 18px;
      height: 18px;
    }
  }
  .col-11 {
    display: flex;
    h2 {
      margin: auto;
      font-weight: 500;
      font-size: 16px;
      opacity: 0.7;
    }
  }
}
</style>
<script>
export default {};
</script>