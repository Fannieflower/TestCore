using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class PackPhysicsAttrHelper : TBeanSerializer<PackPhysicsAttr>
	{
		
		public static PackPhysicsAttrHelper OBJ = new PackPhysicsAttrHelper();
		
		public static PackPhysicsAttrHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PackPhysicsAttr structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("packs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.Pack> value;
						
						value = new List<com.vip.tpc.api.model.Pack>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.Pack elem0;
								
								elem0 = new com.vip.tpc.api.model.Pack();
								com.vip.tpc.api.model.PackHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPacks(value);
					}
					
					
					
					
					
					if ("carrierCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierCode(value);
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
		
		
		public void Write(PackPhysicsAttr structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetPacks() != null) {
				
				oprot.WriteFieldBegin("packs");
				
				oprot.WriteListBegin();
				foreach(com.vip.tpc.api.model.Pack _item0 in structs.GetPacks()){
					
					
					com.vip.tpc.api.model.PackHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packs can not be null!");
			}
			
			
			if(structs.GetCarrierCode() != null) {
				
				oprot.WriteFieldBegin("carrierCode");
				oprot.WriteString(structs.GetCarrierCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrierCode can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PackPhysicsAttr bean){
			
			
		}
		
	}
	
}