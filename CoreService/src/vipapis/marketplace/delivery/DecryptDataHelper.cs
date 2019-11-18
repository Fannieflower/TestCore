using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class DecryptDataHelper : TBeanSerializer<DecryptData>
	{
		
		public static DecryptDataHelper OBJ = new DecryptDataHelper();
		
		public static DecryptDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DecryptData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("decrypt_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.delivery.DecryptItem> value;
						
						value = new List<vipapis.marketplace.delivery.DecryptItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.delivery.DecryptItem elem0;
								
								elem0 = new vipapis.marketplace.delivery.DecryptItem();
								vipapis.marketplace.delivery.DecryptItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDecrypt_items(value);
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
		
		
		public void Write(DecryptData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_id can not be null!");
			}
			
			
			if(structs.GetDecrypt_items() != null) {
				
				oprot.WriteFieldBegin("decrypt_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.delivery.DecryptItem _item0 in structs.GetDecrypt_items()){
					
					
					vipapis.marketplace.delivery.DecryptItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("decrypt_items can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DecryptData bean){
			
			
		}
		
	}
	
}