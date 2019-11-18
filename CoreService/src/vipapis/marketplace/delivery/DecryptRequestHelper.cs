using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class DecryptRequestHelper : TBeanSerializer<DecryptRequest>
	{
		
		public static DecryptRequestHelper OBJ = new DecryptRequestHelper();
		
		public static DecryptRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DecryptRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("encrypt_datas".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.delivery.EncryptData> value;
						
						value = new List<vipapis.marketplace.delivery.EncryptData>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.delivery.EncryptData elem1;
								
								elem1 = new vipapis.marketplace.delivery.EncryptData();
								vipapis.marketplace.delivery.EncryptDataHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetEncrypt_datas(value);
					}
					
					
					
					
					
					if ("extend_infos".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<vipapis.marketplace.delivery.DecryptExtendKey?, string> value;
						
						value = new Dictionary<vipapis.marketplace.delivery.DecryptExtendKey?, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.delivery.DecryptExtendKey? _key3;
								string _val3;
								
								_key3 = vipapis.marketplace.delivery.DecryptExtendKeyUtil.FindByName(iprot.ReadString());
								
								_val3 = iprot.ReadString();
								
								value.Add(_key3, _val3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetExtend_infos(value);
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
		
		
		public void Write(DecryptRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetEncrypt_datas() != null) {
				
				oprot.WriteFieldBegin("encrypt_datas");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.delivery.EncryptData _item0 in structs.GetEncrypt_datas()){
					
					
					vipapis.marketplace.delivery.EncryptDataHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("encrypt_datas can not be null!");
			}
			
			
			if(structs.GetExtend_infos() != null) {
				
				oprot.WriteFieldBegin("extend_infos");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< vipapis.marketplace.delivery.DecryptExtendKey?, string > _ir0 in structs.GetExtend_infos()){
					
					vipapis.marketplace.delivery.DecryptExtendKey? _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0.ToString());  
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DecryptRequest bean){
			
			
		}
		
	}
	
}