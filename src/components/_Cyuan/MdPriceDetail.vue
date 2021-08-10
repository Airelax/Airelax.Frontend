<template>
  <div v-if="price" class="collapse position-absolute" id="mdPriceDetail">
    <div class="header d-flex align-items-center">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-toggle="collapse"
        href="#mdPriceDetail"
        aria-label="Close"
      ></button>
      <div class="title mx-auto">價格明細</div>
    </div>
    <div class="body">
      <div class="row">
        <div class="col">
          ${{ convertToLocaleString(Number(price.sweetPrice)) }}x{{
            nightCount
          }}晚
        </div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.sweetPrice) * nightCount) }}
        </div>
      </div>
      <div class="row" v-if="price.Fee.CleanFee">
        <div class="col">清潔費</div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.Fee.CleanFee)) }}
        </div>
      </div>
      <div class="row" v-if="price.Fee.ServiceFee">
        <div class="col">服務費</div>
        <div class="col">
          ${{ convertToLocaleString(Number(price.Fee.ServiceFee)) }}
        </div>
      </div>

      <div class="row" v-if="price.Fee.taxFee">
        <p class="col">稅額</p>
        <p class="col">
          ${{ convertToLocaleString(Number(price.Fee.taxFee)) }}
        </p>
      </div>
    </div>
  </div>
</template>
<style lang="scss" scoped>
.position-absolute {
  border: 0.5px solid #ededed;
  box-shadow: 0px 1px 15px 0.5px #aaa;
  background-color: #fff;
  border-radius: 18px;
  z-index: 18;
  width: 250px;
  left: 480px;
  .header {
    color: #000;
    padding: 20px 0 20px 20px;
    .btn-close {
      font-size: 12px;
      opacity: 1;
    }
  }
  .body {
    border-top: 0.5px solid #ededed;
    padding-bottom: 10px;
    .row {
      padding: 0 20px;
      margin: 10px 0;
      .col:nth-of-type(1) {
        text-align: start;
      }
      .col:nth-of-type(2) {
        text-align: end;
      }
    }
  }
}
</style>
<script>
export default {
  props: {
    price: {
      type: Object,
    },
    nightCount: {
      type: Number,
    },
  },
  methods: {
    convertToLocaleString(price) {
      return price.toLocaleString();
    },
    plusServiceFee(price, nightCount) {
      return Math.round(
        (Number(price.sweetPrice) * nightCount + Number(price.Fee.ServiceFee)) /
          nightCount
      ).toLocaleString();
    },
    getTotal(price, nightCount) {
      let feeTotal;
      let sweetprice = price.sweetPrice;
      let cleanFee = price.Fee.CleanFee;
      let taxFee = price.Fee.taxFee;
      let serviceFee = price.Fee.ServiceFee;
      if (cleanFee && taxFee && serviceFee) {
        feeTotal = Number(cleanFee) + Number(serviceFee) + Number(taxFee);
      } else if (!cleanFee && !taxFee && !serviceFee) {
        feeTotal = Number(serviceFee);
      } else if (cleanFee && !taxFee && serviceFee) {
        feeTotal = Number(serviceFee) + Number(cleanFee);
      } else if (!cleanFee && taxFee && serviceFee) {
        feeTotal = Number(taxFee) + Number(serviceFee);
      }
      return (Number(sweetprice) * nightCount + feeTotal).toLocaleString();
    },
  },
};
</script>