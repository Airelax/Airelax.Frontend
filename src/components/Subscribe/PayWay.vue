<template>
  <div class="row payWay d-md-none">
    <h3>付款方式</h3>
    <div
      class="col-12 btn"
      type="button"
      data-bs-toggle="offcanvas"
      data-bs-target="#credit"
      aria-controls="credit"
    >
      <img src="@/assets/image/Subscribe/creditCard.svg" alt="creditCard" />
      <p>信用卡或簽帳卡</p>
    </div>
    <div class="col-12 btn">
      <img src="@/assets/image/Subscribe/GooglePay.svg" alt="googlePay" />
      <p>GooglePay</p>
    </div>
  </div>

  <div
    class="offcanvas offcanvas-bottom creditOffcanvas"
    tabindex="-1"
    id="credit"
    aria-labelledby="creditLabel"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <h5 class="offcanvas-title" id="creditLabel">新增信用卡詳情</h5>
    </div>
    <div class="offcanvas-body small">
      <CreditVisaForm></CreditVisaForm>
    </div>
    <div class="offcanvas-footer">
      <div class="btn btn-dark" data-bs-dismiss="offcanvas">完成</div>
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
import CreditVisaForm from "../Subscribe/CreditVisaForm.vue";
export default {
  components: {
    CreditVisaForm,
  },
};
</script>