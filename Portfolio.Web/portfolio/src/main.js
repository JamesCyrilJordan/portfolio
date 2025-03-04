import { createApp } from 'vue'
import App from './App.vue'
import * as VueRouter from 'vue-router'
import ResumePage from './views/Resume.vue';
import ProjectsPage from './views/Projects.vue'

createApp(App)
	.use(VueRouter.createRouter({
		history: VueRouter.createWebHistory(process.env.BASE_URL),
		routes: [{
			path: '/resume',
			component: ResumePage,
		}, {
			path: '/projects',
			component: ProjectsPage,
			}
		]
	}))
	.mount('#app')
