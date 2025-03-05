import { createApp } from 'vue';
import App from './App.vue';
import * as VueRouter from 'vue-router';
import BootstrapVue3 from 'bootstrap-vue-3';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue-3/dist/bootstrap-vue-3.css';

// views
import ResumePage from './views/Resume.vue';
import ProjectsPage from './views/Projects.vue';
import BioPage from './views/Bio.vue';
import NotFoundPage from './views/NotFoundPage.vue';

const app = createApp(App)
	.use(VueRouter.createRouter({
		history: VueRouter.createWebHistory(process.env.BASE_URL),
		routes: [{
			path: '/resume',
			component: ResumePage,
		}, {
			path: '/projects',
			component: ProjectsPage,
		}, {
			path: '/bio',
			component: BioPage,
		}, {
			path: '/:pathMatch(.*)*',
			component: NotFoundPage,
		}
		]
	}));


app.use(BootstrapVue3);
app.mount('#app');
