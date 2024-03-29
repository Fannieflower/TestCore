using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.invoice{
	
	
	
	public class GetInvoicesResponseHelper : TBeanSerializer<GetInvoicesResponse>
	{
		
		public static GetInvoicesResponseHelper OBJ = new GetInvoicesResponseHelper();
		
		public static GetInvoicesResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetInvoicesResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("invoices".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.invoice.Invoice> value;
						
						value = new List<vipapis.marketplace.invoice.Invoice>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.invoice.Invoice elem0;
								
								elem0 = new vipapis.marketplace.invoice.Invoice();
								vipapis.marketplace.invoice.InvoiceHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetInvoices(value);
					}
					
					
					
					
					
					if ("has_next".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHas_next(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(GetInvoicesResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetInvoices() != null) {
				
				oprot.WriteFieldBegin("invoices");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.invoice.Invoice _item0 in structs.GetInvoices()){
					
					
					vipapis.marketplace.invoice.InvoiceHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoices can not be null!");
			}
			
			
			if(structs.GetHas_next() != null) {
				
				oprot.WriteFieldBegin("has_next");
				oprot.WriteBool((bool)structs.GetHas_next());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("has_next can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetInvoicesResponse bean){
			
			
		}
		
	}
	
}