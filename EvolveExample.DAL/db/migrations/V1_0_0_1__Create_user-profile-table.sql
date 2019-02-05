set search_path to public;

create table public.userprofile(
	userid int primary key,
	username text not null
)