using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class PricingReceiptRespHelper : TBeanSerializer<PricingReceiptResp>
	{
		
		public static PricingReceiptRespHelper OBJ = new PricingReceiptRespHelper();
		
		public static PricingReceiptRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PricingReceiptResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("hasNext".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasNext(value);
					}
					
					
					
					
					
					if ("pricingReceipts".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.price.PricingReceipt> value;
						
						value = new List<com.vip.xstore.cc.price.PricingReceipt>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.price.PricingReceipt elem0;
								
								elem0 = new com.vip.xstore.cc.price.PricingReceipt();
								com.vip.xstore.cc.price.PricingReceiptHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPricingReceipts(value);
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
		
		
		public void Write(PricingReceiptResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHasNext() != null) {
				
				oprot.WriteFieldBegin("hasNext");
				oprot.WriteBool((bool)structs.GetHasNext());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasNext can not be null!");
			}
			
			
			if(structs.GetPricingReceipts() != null) {
				
				oprot.WriteFieldBegin("pricingReceipts");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.price.PricingReceipt _item0 in structs.GetPricingReceipts()){
					
					
					com.vip.xstore.cc.price.PricingReceiptHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PricingReceiptResp bean){
			
			
		}
		
	}
	
}