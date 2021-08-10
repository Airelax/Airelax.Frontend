<template>
    <div class="mix">
        <div class="menu">
			<a href="#" class="logo"><img src="./image/logo.png" alt="logo"></a>
			<div class="min_search d-none" @click="show">
			<button type="button" class="form-control " style="box-shadow:3px 3px 12px #cccccc;">開始搜尋
				<div class="iconSlt"><i class="fa fa-search"></i></div>
			</button>
			</div>
			<div class="d-flex align-items-center">
			<button type="button" id="register">成為房東 / 體驗達人</button>
			<Member></Member>
			</div>
		</div>
		
			<keep-alive>
				<div class="search-div" v-show="isShow">
					<SearchBar></SearchBar>
				</div>
			</keep-alive>
    </div>
</template>

<script>
import Member from  '../Airbnb/Member';
import SearchBar from '../Airbnb/SearchBar';
export default {
	data(){
		return{
			isShow: false,
			date:{}
		}
	},
    components:{Member, SearchBar},
	mounted(){
		//下滑fixed
		let register = document.getElementById('register');
        window.addEventListener("scroll", function() {
            let top = document.documentElement.scrollTop;
			let mix = document.querySelector('.mix');
			let minSearch = document.querySelector('.min_search');
            if(top>100){
                mix.classList.add('fixed');
				register.classList.add('toggle');
				minSearch.classList.remove('d-none');
            }
            else{
                mix.classList.remove('fixed');
				register.classList.remove('toggle');
				minSearch.classList.add('d-none');
            }
        });
	},
	methods:{
		show(){
			let vm = this
			this.isShow = true;
			let minSearch = document.querySelector('.min_search');
			minSearch.classList.add('d-none');
			window.addEventListener('scroll',()=>{
				let top = document.documentElement.scrollTop;
				if(top>100){
					minSearch.classList.remove('d-none');
				}
				else{
					minSearch.classList.add('d-none');
				}
				vm.isShow = false;
			})
		}
	}
}
</script>

<style lang="scss" scoped>
.mix{
	width: 100%;
	height: fit-content;
	position: absolute;
	padding: 1rem 0;
	top: 0;
	&.fixed{
		position: fixed;
		top: 0%;
		background-color: #ffffff;
		transition: .3s;
		z-index: 20;
		box-shadow: 3px 3px 5px rgb(160, 159, 159);
	}
	.search-div{
		width: 100%;
		transition: .3s;
		height: 5rem;
	}
	.menu {
		width: 100%;
		display: flex;
		justify-content: space-around;
		background-color: transparent;
		img{
			width: 10rem;
		}
		.logo {
			margin-right: 60vw;
		}
		span {
			margin-right: 12vw;
		}
		li {
			display: inline-block;
		}
		.nav {
			a {
				font-size: 16px;
				color: #ffffff;
				line-height: 40px;
				text-align: center;
				text-decoration: none;
				padding: 00px 16px;
			}
		}
		#register {
			font-size: 14px;
			font-weight: bold;
			color: #ffffff;
			margin-right: 1rem;
			background-color: transparent;
			border: none;
			padding: 1rem 1rem;
			&.toggle{
				color: #000;
			}
			&:hover {
				background-color: rgba(255, 255, 255, 0.2);
				border-radius: 30px;
			}
		}
		.login {
			#login {
				display: flex;
				justify-content: end;
				align-items: center;
				padding: 5px 8px;
				border-radius: 20px;
				border: none;
			}
			label {
				font-size: 17px;
				padding-left: 5px;
				display: flex;
				justify-content: center;
				align-items: center;
			}
			i {
				font-size: 28px;
				color: #484848d5;
				padding-left: 12px;
			}
		}
		.min_search {
			display: flex;
			justify-content: center;
			align-items: center;
			position: absolute;
			top: 20%;
			transition: .3s;
			button {
				width: 300px;
				height: 50px;
				display: flex;
				justify-content: left;
				align-items: center;
				background: #ffffff;
				border: none;
				font-weight: bold;
				float: left;
				color: #222222;
				text-align: left;
				padding-left: 35px;
				border-radius: 50px;
				&:hover,
				&:focus,
				&:active {
					outline: none;
				}
				.iconSlt {
					position: relative;
					left: 150px;
					height: 40px;
					width: 40px;
					line-height: 40px;
					border-radius: 50px;
					background: #ff385c;
					color: #ffff;
					text-align: center;
				}
			}
		}
	}
}
</style>