
from django.contrib.auth import authenticate, login,  logout
from django.contrib.auth.forms import AuthenticationForm
from traditional_product_app.forms import CreateAcountForm, Productform, contactusform
from traditional_product_app.models import Product, UserProfile
from django.shortcuts import render, redirect

def index(request):
   context={
      'conferences': Product.objects.all(),
   }
   return render(request,'index.html' , context)


def create_account_view(request):
    if request.method == 'POST':
        form = CreateAcountForm(request.POST, request.FILES)
        if form.is_valid():
            user = form.save()
            profile_picture = form.cleaned_data.get('profile_picture')
            UserProfile.objects.create(user=user, profile_picture=profile_picture)

            login(request, user)
            return redirect('index')
        else:
            print(form.errors)
    else:
        form = CreateAcountForm()
    
    return render(request, 'create_account.html', {'form': form})



def login_view(request):
    if request.method == 'POST':
        form = AuthenticationForm(request, data=request.POST)
        if form.is_valid():
            username = form.cleaned_data.get('username')
            password = form.cleaned_data.get('password')
            user = authenticate(request, username=username, password=password)
            if user is not None:
                login(request, user)
                return redirect('index')
    else:
        form = AuthenticationForm()
    return render(request, 'login.html', {'form': form})

def create_product(request):
    if request.method == 'POST':
        form = Productform(request.POST, request.FILES)
        if form.is_valid():
            form.save()
            return redirect('index')  
    else:
        form = Productform()
    
    return render(request, 'create_product.html', {'form': form})


def TextToUS(request):
    if request.method == 'POST':
        form = contactusform(request.POST)
        if form.is_valid():
            form.save()
            return redirect('index')  
    return render(request, 'index.html')


def logout_view(request):
    logout(request)
    return redirect('index')     