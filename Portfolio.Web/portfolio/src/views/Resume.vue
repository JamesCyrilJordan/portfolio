<template>
	<div>
		<h1>Resume</h1>
		<div v-for="position in positions"
			:key="position.id">
			<h3>job title here</h3>
			<p>job description here</p>
		</div>
	</div>
</template>

<script>
	import axios from 'axios';

	export default {
		name: "ResumePage",
		data() {
			return {
				experiences: [],
			}
		},
		async created() {
			const response = await axios.get('/api/Position');
			console.log(response.data);
			const Positions = response.data;
			this.Positions = Positions;
		}
	}
</script>
<!--<template>
	<h1>Resume</h1>
	<div class="grid-wrap">

	</div>
</template>

<script>
	import { experiences } from '../temp-data';

	export default {
		name: "ResumePage",
		data() {
			return {
				experiences,
			}
		}
	}
</script>-->