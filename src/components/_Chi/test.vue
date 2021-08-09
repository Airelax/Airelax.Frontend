<template>
    <Carousel :settings="settings" :breakpoints="breakpoints">
		<Slide v-for="slide in 10" :key="slide">
			<div class="carousel__item">{{ slide }}</div>
		</Slide>

		<template #addons>
			<Navigation />
		</template>
	</Carousel>
</template>

<script>
import { Carousel, Slide, Navigation } from "vue3-carousel";
export default {
    components: {
		Carousel,
		Navigation,
		Slide
	},
	setup() {
		return {
			// carousel settings
			settings: {
				itemsToShow: 1,
				snapAlign: "center"
			},
			// breakpoints are mobile first
			// any settings not specified will fallback to the carousel settings
			breakpoints: {
				// 700px and up
				700: {
					itemsToShow: 3.5,
					snapAlign: "center"
				},
				// 1024 and up
				1024: {
					itemsToShow: 5,
					snapAlign: "start"
				}
			}
		};
	}
}
</script>

<style scoped>
    body {
	padding: 20px;
}

.carousel__item {
	min-height: 200px;
	width: 100%;
	background-color: #642afb;
	color: white;
	font-size: 20px;
	border-radius: 8px;
	display: flex;
	justify-content: center;
	align-items: center;
}

.carousel__slide {
	padding: 10px;
}

.carousel__prev,
.carousel__next {
	box-sizing: content-box;
	border: 5px solid white;
}

</style>