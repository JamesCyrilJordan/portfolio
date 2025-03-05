<template>
	<div>
		<b-navbar toggleable="lg" type="dark" variant="info">

			<b-navbar-brand href="#">James Jordan</b-navbar-brand>

			<b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

			<b-collapse id="nav-collapse" is-nav>
				<b-navbar-nav>
					<router-link to="/resume">
						<b-nav-item href="#">Resume</b-nav-item>
					</router-link>
					<router-link to="/projects">
						<b-nav-item href="#">Projects</b-nav-item>
					</router-link>
					<router-link to="/bio">
						<b-nav-item href="#">Bio</b-nav-item>
					</router-link>
				</b-navbar-nav>
			</b-collapse>
		</b-navbar>
	</div>
</template>

<script>
	export default {
		name: "NavBar",
	}
</script>