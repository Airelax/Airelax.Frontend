<template>
  <div
    class="offcanvas offcanvas-bottom"
    tabindex="-1"
    id="createWish"
    aria-labelledby="wishTitle"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <p class="offcanvas-title" id="wishTitle">為你的心願單取名</p>
    </div>
    <div class="offcanvas-body small">
      <form class="form-floating">
        <input
          type="email"
          class="form-control"
          id="floatingInputValue"
          value="逮爸"
        />
        <label for="floatingInputValue">心願單名稱</label>
      </form>
      <div class="maxLength"><label for="">最多50字元</label></div>
    </div>
    <div class="offcanvas-footer">
      <div class="btn">建立</div>
    </div>
  </div>
</template>

<style lang="scss" scoped>
.offcanvas {
  border-top-left-radius: 12px;
  border-top-right-radius: 12px;
  height: auto;
  .offcanvas-header {
    border-bottom: 0.5px solid #ededed;
    padding: 20px 30px;
    .btn-close {
      color: #000;
      opacity: 1;
      font-size: 12px;
    }
    .btn-close:hover {
      background-color: #efefef80;
      border-radius: 50%;
    }
    .offcanvas-title {
      color: #000;
      margin: auto;
      font-size: 16px;
      font-weight: 500;
    }
  }
  .offcanvas-body {
    padding: 20px 30px;
    .form-floating {
      .form-control {
        border-radius: 10px;
      }
      .form-control:link {
        border: 1px solid #616161;
      }
      .form-control:focus {
        border: 2px solid #000;
      }
    }
    .maxLength {
      font-size: 12px;
      text-align: start;
      font-weight: 200;
      padding-left: 5px;
      padding-top: 5px;
      color: #bcbcbc;
    }
  }
  .offcanvas-footer {
    border-top: 0.5px solid #ededed;

    padding: 20px 30px;
    .btn {
      font-size: 16px;
      display: block;
      padding: 10px;
      background-color: #000;
      color: #fff;
      border-radius: 10px;
    }
  }
}
</style>


<script>
export default {};
</script>