import { withNavigationWatcher } from './contexts/navigation';
import { HomePage, TasksPage, ProfilePage, HeuristicsPage } from './pages';

const routes = [
  {
    path: '/tasks',
    component: TasksPage
  },
  {
    path: '/profile',
    component: ProfilePage
  },
  {
    path: '/home',
    component: HomePage
    },
    {
        path: '/heuristics',
        component: HeuristicsPage
    }
];

export default routes.map(route => {
  return {
    ...route,
    component: withNavigationWatcher(route.component)
  };
});
