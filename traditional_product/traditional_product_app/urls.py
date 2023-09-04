from django.conf import settings
from django.conf.urls.static import static
from django.urls import path
from . import views
urlpatterns = [
   path("",views.index, name="index"),
   path('create_account', views.create_account_view, name='create_account'),
   path('login_view', views.login_view, name='login_view'),
   path('logout/', views.logout_view, name='logout'),
#    path('conferencedetail/<int:id>/', views.Detail_of_conference, name='conferencedetail'),
   path('contactus', views.TextToUS, name='contactus'),
   path('create_product/', views.create_product, name='create_product'),
]
if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)