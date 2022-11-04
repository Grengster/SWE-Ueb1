CREATE SCHEMA public AUTHORIZATION postgres;

CREATE TABLE public.weatherhistory (
	"temp" int4 NOT NULL,
	"date" date NOT NULL
);

ALTER TABLE public.weatherhistory ADD "temp" int4 NOT NULL;

ALTER TABLE public.weatherhistory ADD "date" date NOT NULL;

INSERT INTO public.weatherhistory(temp, date)
VALUES (13, '04.11.2022');


