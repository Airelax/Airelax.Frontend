<template>
  <div class="row payWay d-md-none">
    <h3>付款方式</h3>
    <div class="col-12 btn">
      <img src="@/assets/image/Subscribe/creditCard.svg" alt="creditCard" />
      <p>信用卡或簽帳卡</p>
    </div>
    <div class="col-12 btn">
      <img src="@/assets/image/Subscribe/GooglePay.svg" alt="googlePay" />
      <p>GooglePay</p>
    </div>
  </div>
</template>

<style lang="scss" scoped>
.payWay {
  .col-12 {
    padding: 10px;
    display: flex;
    align-items: center;
    img {
      width: 30px;
    }
    p {
      font-weight: 300;
      margin-left: 20px;
    }
  }
}
</style>

<script>
export default {};
</script>