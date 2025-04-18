--
-- PostgreSQL database dump
--
ALTER TABLE IF EXISTS public.gcp ADD PRIMARY KEY (gcp_cd);

ALTER TABLE IF EXISTS public.gtin
    ADD CONSTRAINT gcp_cd_fkey FOREIGN KEY (gcp_cd)
    REFERENCES public.gcp (gcp_cd);

CREATE INDEX w_id ON public.stock(w_id);

CREATE INDEX wid ON public.em(w_id);