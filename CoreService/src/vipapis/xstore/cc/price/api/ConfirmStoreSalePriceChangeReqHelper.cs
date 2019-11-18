using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class ConfirmStoreSalePriceChangeReqHelper : TBeanSerializer<ConfirmStoreSalePriceChangeReq>
	{
		
		public static ConfirmStoreSalePriceChangeReqHelper OBJ = new ConfirmStoreSalePriceChangeReqHelper();
		
		public static ConfirmStoreSalePriceChangeReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmStoreSalePriceChangeReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("store_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_code(value);
					}
					
					
					
					
					
					if ("sale_price_change_nos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSale_price_change_nos(value);
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
		
		
		public void Write(ConfirmStoreSalePriceChangeReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStore_code() != null) {
				
				oprot.WriteFieldBegin("store_code");
				oprot.WriteString(structs.GetStore_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSale_price_change_nos() != null) {
				
				oprot.WriteFieldBegin("sale_price_change_nos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSale_price_change_nos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sale_price_change_nos can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmStoreSalePriceChangeReq bean){
			
			
		}
		
	}
	
}